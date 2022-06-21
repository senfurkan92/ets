<template>
  <div>
    <form @submit.prevent="submit">
      <div>
        <label for="title-input" class="font-bold">
          Title:
        </label>
        <input
            v-model="v$.title.$model"
            id="title-input"
            type="text"
            placeholder="Category Title"
            class="input input-bordered w-full mb-4"
          />
        <div v-if="v$.title.$dirty">
          <span class="text-error" v-if="v$.title.required.$invalid">
            {{v$.title.required.$message}}
          </span>
          <span class="text-error" v-else-if="v$.title.maxLength.$invalid">
            {{v$.title.maxLength.$message}}
          </span>
        </div>
      </div>
        <div class="text-right">
          <button class="btn btn-success" :disabled="v$.$invalid">
            Add
          </button>
        </div>
    </form>
  </div>
</template>

<script setup>
import { reactive } from 'vue';
import useVuelidate from '@vuelidate/core';
import { required, maxLength } from '@vuelidate/validators';
import { useStore } from 'vuex';

const store = useStore();

const form = reactive({
  title: '',
});

const rules = {
  title: {
    required,
    maxLength: maxLength(15),
  },
};

const v$ = useVuelidate(rules, form);

const submit = () => {
  const payload = {
    name: v$.value.title.$model,
  };
  store.dispatch('category/insertItem', payload)
    .then((resp) => {
      if (resp) {
        alert('Success');
      } else {
        alert('Failed');
      }
    });
};
</script>
