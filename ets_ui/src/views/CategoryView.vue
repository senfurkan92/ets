<template>
  <div class="text-center mb-10">
    <h2 class="text-4xl uppercase font-semibold font-title tracking-widest">
      {{$route.params.categoryName}}
    </h2>
  </div>
  <div class="flex flex-wrap justify-center">
    <div v-for="n in 40" :key="n" class="py-2 px-2">
      <ActivityCard />
    </div>
  </div>
</template>

<script setup>
import ActivityCard from '@/components/ui/ActivityCard.vue';
</script>

<style>

</style>
