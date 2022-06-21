import { createStore } from 'vuex';
import activityModule from './modules/activity';
import categoryModule from './modules/category';

export default createStore({
  state() {
    return {
      theme: 'winter',
    };
  },
  mutations: {
    init(state) {
      state.theme = localStorage.getItem('daisyTheme') ? localStorage.getItem('daisyTheme') : 'winter';
    },
    changeTheme(state, payload) {
      state.theme = payload;
      localStorage.setItem('daisyTheme', payload);
    },
  },
  actions: {

  },
  modules: {
    activity: activityModule,
    category: categoryModule,
  },
});
