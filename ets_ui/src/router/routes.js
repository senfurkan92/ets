import Home from '@/views/HomeView.vue';

export default [
  {
    path: '/',
    component: Home,
    name: 'Home',
  },
  {
    path: '/:categoryName/:categoryId',
    component: () => import('../views/CategoryView.vue'),
    name: 'Category',
  },
  {
    path: '/:categoryName/:categoryId/:activityName/:activityId',
    component: () => import('../views/ActivityView.vue'),
    name: 'Activity',
  },
];
