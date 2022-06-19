<template>
  <Layout>
    <template #header>
      <header>
        <AppHeader/>
      </header>
    </template>
    <template #main>
      <main>Main</main>
    </template>
    <template #footer>
      <AppFooter/>
    </template>
  </Layout>
</template>

<script setup>
import Layout from '@/components/layout/AppLayout.vue';
import AppHeader from '@/components/layout/AppNavbar.vue';
import AppFooter from '@/components/layout/AppFooter.vue';
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
