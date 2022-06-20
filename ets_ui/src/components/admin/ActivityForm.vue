<template>
  <div>
    <form @submit.prevent="submit">
      <!-- CATEGORY -->
      <div>
        <label for="category-input" class="font-bold">
          Category *:
        </label>
        <select
            v-model="v$.categoryId.$model"
            id="category-input"
            class="input input-bordered w-full mb-4"
        >
            <option :value="1">Tiyatro</option>
        </select>
        <div v-if="v$.categoryId.$dirty">
          <span class="text-error" v-if="v$.categoryId.$invalid">
            {{v$.categoryId.required.$message}}
          </span>
        </div>
      </div>
      <!-- TITLE -->
      <div>
        <label for="title-input" class="font-bold">
          Title *:
        </label>
        <input
            v-model="v$.title.$model"
            id="title-input"
            type="text"
            placeholder="Title"
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
      <!-- DESCRIPTION -->
      <div>
        <label for="description-input" class="font-bold">
          Description *:
        </label>
        <textarea
            v-model="v$.description.$model"
            id="description-input"
            type="text"
            placeholder="Description"
            class="input input-bordered w-full mb-4"
            rows="5"
        ></textarea>
        <div v-if="v$.description.$dirty">
          <span class="text-error" v-if="v$.description.required.$invalid">
            {{v$.description.required.$message}}
          </span>
        </div>
      </div>
      <!-- CITY -->
      <div>
        <label for="city-input" class="font-bold">
          City *:
        </label>
        <input
            v-model="v$.city.$model"
            id="city-input"
            type="text"
            placeholder="City"
            class="input input-bordered w-full mb-4"
          />
        <div v-if="v$.city.$dirty">
          <span class="text-error" v-if="v$.city.required.$invalid">
            {{v$.city.required.$message}}
          </span>
        </div>
      </div>
      <!-- PLACE TITLE -->
      <div>
        <label for="placeTitle-input" class="font-bold">
          Place Title *:
        </label>
        <input
            v-model="v$.placeTitle.$model"
            id="placeTitle-input"
            type="text"
            placeholder="Place Title"
            class="input input-bordered w-full mb-4"
          />
        <div v-if="v$.placeTitle.$dirty">
          <span class="text-error" v-if="v$.placeTitle.required.$invalid">
            {{v$.placeTitle.required.$message}}
          </span>
        </div>
      </div>
      <!-- MAP LOCATION -->
      <div>
        <label for="mapLocation-input" class="font-bold">
          Map Location *:
        </label>
        <input
            v-model="v$.mapLocation.$model"
            id="mapLocation-input"
            type="text"
            placeholder="Map Location"
            class="input input-bordered w-full mb-4"
          />
        <div v-if="v$.mapLocation.$dirty">
          <span class="text-error" v-if="v$.mapLocation.required.$invalid">
            {{v$.mapLocation.required.$message}}
          </span>
          <span class="text-error" v-else-if="v$.mapLocation.url.$invalid">
            {{v$.mapLocation.url.$message}}
          </span>
        </div>
      </div>
      <!-- ADDRESS -->
      <div>
        <label for="adress-input" class="font-bold">
          Address *:
        </label>
        <input
            v-model="v$.address.$model"
            id="address-input"
            type="text"
            placeholder="Adress"
            class="input input-bordered w-full mb-4"
          />
        <div v-if="v$.address.$dirty">
          <span class="text-error" v-if="v$.address.required.$invalid">
            {{v$.address.required.$message}}
          </span>
        </div>
      </div>
      <!-- START DATE -->
      <div>
        <label for="startDate-input" class="font-bold">
          Start Date *:
        </label>
        <input
            v-model="v$.startDate.$model"
            id="startDate-input"
            type="datetime"
            placeholder="Start Date"
            class="input input-bordered w-full mb-4"
          />
        <div v-if="v$.startDate.$dirty">
          <span class="text-error" v-if="v$.startDate.required.$invalid">
            {{v$.startDate.required.$message}}
          </span>
        </div>
      </div>
      <!-- END DATE -->
      <div>
        <label for="endDate-input" class="font-bold">
          End Date:
        </label>
        <input
            v-model="v$.endDate.$model"
            id="endDate-input"
            type="datetime"
            placeholder="End Date"
            class="input input-bordered w-full mb-4"
          />
      </div>
      <!-- POSTER -->
      <div>
        <label for="poster-input" class="font-bold">
          Poster:
        </label>
        <input
            id="poster-input"
            type="file"
            class="input input-bordered w-full mb-4"
          />
      </div>
       <!-- IMAGES -->
      <div>
        <label for="images-input" class="font-bold">
          Images:
        </label>
        <input
            id="images-input"
            type="file"
            class="input input-bordered w-full mb-4"
            multiple
          />
      </div>
      <!-- ADD BUTTON -->
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
import { required, maxLength, url } from '@vuelidate/validators';

const form = reactive({
  title: '',
  description: '',
  city: '',
  placeTitle: '',
  mapLocation: '',
  address: '',
  startDate: '',
  endDate: '',
  categoryId: '',
});

const rules = {
  title: {
    required,
    maxLength: maxLength(200),
  },
  description: {
    required,
  },
  city: {
    required,
  },
  placeTitle: {
    required,
  },
  mapLocation: {
    required,
    url,
  },
  address: {
    required,
  },
  startDate: {
    required,
  },
  endDate: {
  },
  categoryId: {
    required,
  },
};

const v$ = useVuelidate(rules, form);

const submit = () => {
  console.log(v$.value);
};
</script>
