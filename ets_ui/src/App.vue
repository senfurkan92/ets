<template>
  <Layout>
    <template #header>
      <header>
        <AppHeader/>
      </header>
    </template>
    <template #main>
      <main class="container mx-auto md:py-10 py-5">
        <router-view/>
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
import { onMounted } from 'vue';
import { useStore } from 'vuex';

const store = useStore();

onMounted(() => {
  store.commit('init');
  store.dispatch('category/fetchList');
});
</script>

<style>
*{
  padding: 0;
  margin: 0;
}
</style>
