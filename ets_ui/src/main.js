import { createApp } from 'vue';
import store from '@/store';
import router from '@/router';
import Maska from 'maska';
import App from './App.vue';
import './registerServiceWorker';
import '@/assets/css/index.css';

const app = createApp(App);
app.use(Maska);
app.use(store);
app.use(router);
app.mount('#app');
