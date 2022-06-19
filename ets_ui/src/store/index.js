import { createStore } from 'vuex';

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

  },
});
