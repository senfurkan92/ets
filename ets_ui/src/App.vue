<template>
  <Layout>
    <template #header>
      <header>
        <AppHeader/>
      </header>
    </template>
    <template #main>
      <main>
        <HomeSlider/>
      </main>
    </template>
    <template #footer>
      <footer>
        <AppFooter/>
      </footer>
    </template>
  </Layout>
</template>

<script setup>
import Layout from '@/components/layout/AppLayout.vue';
import AppHeader from '@/components/layout/AppNavbar.vue';
import AppFooter from '@/components/layout/AppFooter.vue';
import HomeSlider from '@/components/ui/Home2Slider.vue';
import { useStore } from 'vuex';

const store = useStore();
store.commit('init');
</script>

<style>
*{
  padding: 0;
  margin: 0;
}
</style>
