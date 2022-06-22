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
            <option v-for="category in $store.state.category.list"
              :key="category.id"
              :value="category.id"
            >
              {{category.name}}
            </option>
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
          Start Date (YYYY-MM-DD HH:MM)*:
        </label>
        <input
            v-model="v$.startDate.$model"
            v-maska="{mask: '####-##-## ##:##'}"
            id="startDate-input"
            type="datetime"
            placeholder="Start Date"
            class="input input-bordered w-full mb-4"
          />
        <div v-if="v$.startDate.$dirty">
          <span class="text-error" v-if="v$.startDate.required.$invalid">
            {{v$.startDate.required.$message}}
          </span>
          <span class="text-error" v-else-if="v$.startDate.date.$invalid">
            Invalid date
          </span>
        </div>
      </div>
      <!-- POSTER -->
      <div>
        <label for="poster-input" class="font-bold">
          Poster:
        </label>
        <div class="grid grid-cols-1">
          <div>
            <input
              id="poster-input"
              type="file"
              class="input input-bordered w-full mb-4"
              ref="posterFile"
              @change="preview"
            />
          </div>
          <div v-if="imgUrl" class="h-40 aspect-5/7">
            <img :src="imgUrl" alt="" class="h-full w-full object-contain"/>
          </div>
        </div>
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
            ref="imageFiles"
          />
      </div>
      <!-- TICKETS -->
      <div>
        <label for="images-input" class="font-bold">
          TICKETS:
        </label>
        <template v-for="ticket, index in tickets" :key="index">
            <div class="grid" style="grid-template-columns: auto max-content">
                <div class="grid grid-cols-2">
                    <div>
                        <input
                            v-model="ticket.title"
                            type="text"
                            :placeholder="`${index+1}. Ticket's Title`"
                            class="input input-bordered w-full mb-4"
                        />
                    </div>
                    <div>
                        <input
                            v-model="ticket.fee"
                            type="number"
                            step="0.01"
                            :placeholder="`${index+1}. Ticket's Fee`"
                            class="input input-bordered w-full mb-4"
                            min="0"
                        />
                    </div>
                </div>
                <div>
                    <button
                        type="button"
                        class="btn btn-error"
                        @click.prevent.stop="tickets.splice(index,1)"
                    >
                        -
                    </button>
                </div>
            </div>
        </template>
        <button class="btn btn-primary" type="button"
          @click.prevent.stop="tickets.push({
            title: '',
            fee: '',
          })"
        >
            Add Ticket
        </button>
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
import { reactive, ref } from 'vue';
import useVuelidate from '@vuelidate/core';
import {
  required,
  maxLength,
  url,
  helpers,
} from '@vuelidate/validators';
import { useStore } from 'vuex';

const store = useStore();

const imgUrl = ref(null);
const posterFile = ref(null);

const preview = (e) => {
  const file = e.target.files[0];
  if (file) {
    imgUrl.value = URL.createObjectURL(file);
  } else {
    imgUrl.value = null;
  }
};

const imageFiles = ref(null);
const tickets = reactive([
  {
    title: 'standart',
    fee: 100,
  },
]);

const form = reactive({
  title: '',
  description: '',
  city: '',
  placeTitle: '',
  mapLocation: '',
  address: '',
  startDate: '',
  categoryId: '',
});

const date = helpers.regex(/[0-9]{4}-(0[1-9]|1[0-2])-(0[1-9]|[1-2][0-9]|3[0-1]) (2[0-3]|[01][0-9]):[0-5][0-9]/);

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
    date,
  },
  categoryId: {
    required,
  },
};

const v$ = useVuelidate(rules, form);

const submit = () => {
  const payload = {
    title: v$.value.title.$model,
    description: v$.value.description.$model,
    city: v$.value.city.$model,
    placeTitle: v$.value.placeTitle.$model,
    mapLocation: v$.value.mapLocation.$model,
    address: v$.value.address.$model,
    startDate: v$.value.startDate.$model,
    categoryId: v$.value.categoryId.$model,
    posterFile: posterFile.value.files[0],
    imageFiles: imageFiles.value.files,
    tickets,
  };

  const formData = new FormData();
  formData.append('title', payload.title);
  formData.append('description', payload.description);
  formData.append('city', payload.city);
  formData.append('placeTitle', payload.placeTitle);
  formData.append('mapLocation', payload.mapLocation);
  formData.append('address', payload.address);
  formData.append('startDate', payload.startDate);
  formData.append('categoryId', payload.categoryId);
  formData.append('posterFile', payload.posterFile);

  if (payload.imageFiles) {
    Array.from(payload.imageFiles).forEach((file) => {
      formData.append('imageFiles', file);
    });
  }

  if (payload.tickets && payload.tickets.length > 0) {
    payload.tickets.forEach((ticket, index) => {
      formData.append(`Tickets[${index}].Title`, ticket.title);
      formData.append(`Tickets[${index}].Fee`, ticket.fee);
    });
  }

  store.dispatch('activity/insertItem', formData)
    .then((resp) => {
      if (resp) {
        alert('Success');
        store.dispatch('activity/fetchList');
      } else {
        alert('Failed');
      }
    });
};
</script>
