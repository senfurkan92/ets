<template>
  <div class="mr-6 text-center flex">
    <label></label>
    <input
      v-model="inputValue"
      type="text"
      placeholder="Search..."
      class="input w-full max-w-xs rounded-r-[0]
        bg-base-100"
      @keydown.enter="search"
    />
    <button class="btn bg-base-200 border-0 hover:bg-base-300 rounded-l-[0]"
      @click="search"
    >
        <svg class="w-5 h-5" fill="none" stroke="currentColor" viewBox="0 0 24 24" xmlns="http://www.w3.org/2000/svg"><path stroke-linecap="round" stroke-linejoin="round" stroke-width="2" d="M21 21l-6-6m2-5a7 7 0 11-14 0 7 7 0 0114 0z"></path></svg>
    </button>
  </div>
</template>

<script setup>
import { ref } from 'vue';
import { useStore } from 'vuex';
import { useRouter } from 'vue-router';

const store = useStore();
const router = useRouter();

const inputValue = ref('');

const search = () => {
  const v = inputValue.value.trim();
  if (v) {
    store.dispatch('activity/fetchFilteredList', {
      contain: v,
    })
      .then((resp) => {
        if (resp) {
          router.push('/activities');
        }
      });
  }
};
</script>
