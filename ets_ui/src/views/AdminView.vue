<template>
  <div>
    <div class="tabs flex justify-center mb-6">
        <a class="tab tab-lg tab-bordered"
          :class="{'tab-active': currentTab.__file.includes('CategoryTable')}"
          @click="changeTab('categories')"
        >
            Categories
        </a>
        <a class="tab tab-lg tab-bordered"
        :class="{'tab-active': currentTab.__file.includes('ActivityTable')}"
          @click="changeTab('activities')"
        >
            Activities
        </a>
    </div>
    <component :is="currentTab"/>
  </div>
</template>

<script setup>
import CategoryTable from '@/components/admin/CategoryTable.vue';
import ActivityTable from '@/components/admin/ActivityTable.vue';

import { shallowRef } from 'vue';

const currentTab = shallowRef(CategoryTable);

const changeTab = (tab) => {
  currentTab.value = tab === 'categories' ? CategoryTable : ActivityTable;
};
</script>
