import { createRouter, createWebHistory } from 'vue-router';
import routes from './routes';

const router = createRouter({
  history: createWebHistory(),
  routes,
});

router.beforeEach((to, from, next) => {
  if (to.meta.auth) {
    // eslint-disable-next-line no-alert
    if (prompt('Password?') === 'etstur') {
      next();
    } else {
      next('/');
    }
  } else {
    next();
  }
});

export default router;
