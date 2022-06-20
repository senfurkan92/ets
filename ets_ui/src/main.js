import { createApp } from 'vue';
import store from '@/store';
import router from '@/router';
import App from './App.vue';
import './registerServiceWorker';
import '@/assets/css/index.css';

const app = createApp(App);
app.use(store);
app.use(router);
app.mount('#app');
