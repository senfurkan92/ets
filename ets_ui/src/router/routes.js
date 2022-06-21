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
    path: '/activities',
    component: () => import('../views/SearchView.vue'),
    name: 'Activities',
  },
  {
    path: '/past-activities',
    component: () => import('../views/PastView.vue'),
    name: 'PastActivities',
  },
  {
    path: '/:categoryName/:categoryId/:activityName/:activityId',
    component: () => import('../views/ActivityView.vue'),
    name: 'Activity',
  },
  {
    path: '/admin',
    component: () => import('../views/AdminView.vue'),
    name: 'Admin',
    meta: {
      auth: true,
    },
  },
];
