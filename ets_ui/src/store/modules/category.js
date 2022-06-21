import axiosInstance from '@/utils/axios-instance';

const module = {
  namespaced: true,
  state() {
    return {
      list: [],
    };
  },
  mutations: {
    setList(state, list) {
      state.list = list;
    },
    pushItem(state, item) {
      state.list.push(item);
    },
    removeItem(state, id) {
      state.list = state.list.filter((x) => x.id !== id);
    },
  },
  actions: {
    async fetchList({ commit }) {
      const resp = await axiosInstance.get('/Categories');
      if (resp.data.success) {
        commit('setList', resp.data.result);
      }
      return resp.data.success;
    },
    async insertItem({ commit }, payload) {
      const resp = await axiosInstance.post('/Categories', payload);
      if (resp.data.success) {
        commit('pushItem', resp.data.result);
      }
      return resp.data.success;
    },
    async deleteItem({ commit }, id) {
      const resp = await axiosInstance.get(`/Categories/Delete/${id}`);
      if (resp.data.success) {
        commit('removeItem', id);
      }
      return resp.data.success;
    },
  },
};

export default module;
