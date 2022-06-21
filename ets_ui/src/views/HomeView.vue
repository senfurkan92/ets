<template>
  <div>
    <HomeSlider/>
  </div>
</template>

<script setup>
import HomeSlider from '@/components/ui/HomeSlider.vue';
import { useStore } from 'vuex';

const store = useStore();

store.dispatch('activity/fetchRecentList');
</script>
