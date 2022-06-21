<template>
  <div>
    <div class="mb-8">
      <ModalBox :title="'Add Acitivity'" :btnContent="'Add Acitivity'">
        <ActivityForm/>
      </ModalBox>
    </div>
    <div class="mb-8 overflow-x-auto">
      <table class="table table-zebra w-full">
        <thead>
          <tr>
            <th>Title</th>
            <th>Category</th>
            <th>Start Date</th>
            <th>Poster</th>
            <th class="text-center">#</th>
          </tr>
        </thead>
        <tbody>
          <tr v-for="activity in $store.state.activity.list"
            :key="activity.id"
          >
            <td>{{activity.title}}</td>
            <td>{{$store.state.category.list.find((x) => x.id == activity.categoryId).name}}</td>
            <td>{{activity.startDate.replace('T', ' ')}}</td>
            <td>
              <div class="h-40 aspect-[5/7]">
                <img
                  class="h-full w-full object-contain"
                  :src="activity.posterPath"
                  alt=""
                />
              </div>
            </td>
            <td class="text-center">
              <button class="btn btn-error"
                @click="remove(activity.id)"
              >-</button>
            </td>
          </tr>
        </tbody>
      </table>
    </div>
  </div>
</template>

<script setup>
import ModalBox from '@/components/ui/ModalBox.vue';
import ActivityForm from '@/components/admin/ActivityForm.vue';
import { onMounted } from 'vue';
import { useStore } from 'vuex';

const store = useStore();

onMounted(() => {
  store.dispatch('activity/fetchList');
});

const remove = (id) => {
  store.dispatch('activity/deleteItem', id);
};
</script>
