<template>
  <div class="text-center mb-10">
    <h2 class="text-4xl font-semibold font-title tracking-widest">
      {{toTurkishUpper($route.params.categoryName)}}
    </h2>
  </div>
  <div class="flex flex-wrap justify-center">
    <div v-if="$store.state.activity.filteredList.length < 1">
      Etkinlik bulunamadı.
    </div>
    <div v-for="activity in $store.state.activity.filteredList"
      :key="activity.id"
      class="py-2 px-2"
    >
      <ActivityCard :item="activity"/>
    </div>
  </div>
</template>

<script setup>
import ActivityCard from '@/components/ui/ActivityCard.vue';
import { watch, onMounted } from 'vue';
import { useRoute } from 'vue-router';
import { useStore } from 'vuex';
import { toTurkishUpper } from '@/utils/methods';

const store = useStore();

const route = useRoute();

onMounted(() => {
  const { categoryId } = route.params;
  if (categoryId) {
    store.dispatch('activity/fetchFilteredList', {
      categoryId,
    });
  }
});

watch((route), () => {
  const { categoryId } = route.params;
  if (categoryId) {
    store.dispatch('activity/fetchFilteredList', {
      categoryId,
    });
  }
});

</script>

<style>

</style>
