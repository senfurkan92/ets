<template>
  <div class="text-center mb-10">
    <h2 class="text-4xl font-semibold font-title tracking-widest">
      ETKİNLİKLER
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
</script>
