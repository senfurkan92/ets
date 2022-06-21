import axiosInstance from '@/utils/axios-instance';

const module = {
  namespaced: true,
  state() {
    return {
      list: [],
      filteredList: [],
      recentList: [],
    };
  },
  mutations: {
    setList(state, list) {
      state.list = list;
    },
    setFilteredList(state, list) {
      state.filteredList = list;
    },
    setRecentList(state, list) {
      state.recentList = list;
    },
    pushItem(state, item) {
      state.list.push(item);
    },
    removeItem(state, id) {
      state.list = state.list.filter((x) => x.id !== id);
    },
  },
  actions: {
    async fetchFilteredList({ commit }, filter) {
      const resp = await axiosInstance.post('/Activities/Filter', filter);
      if (resp.data.success) {
        commit('setFilteredList', resp.data.result);
      }
      return resp.data.success;
    },
    async fetchList({ commit }) {
      const resp = await axiosInstance.get('/Activities');
      if (resp.data.success) {
        commit('setList', resp.data.result);
      }
      return resp.data.success;
    },
    async fetchRecentList({ commit }) {
      const resp = await axiosInstance.post('/Activities/Filter', {
        take: 9,
      });
      if (resp.data.success) {
        commit('setRecentList', resp.data.result);
      }
      return resp.data.success;
    },
    async insertItem({ commit }, payload) {
      const resp = await axiosInstance.post('/Activities', payload, {
        headers: {
          'content-type': 'multipart/form-data',
        },
      });
      if (resp.data.success) {
        commit('pushItem', resp.data.result);
      }
      return resp.data.success;
    },
    async deleteItem({ commit }, id) {
      const resp = await axiosInstance.get(`/Activities/Delete/${id}`);
      if (resp.data.success) {
        commit('removeItem', id);
      }
      return resp.data.success;
    },
    async fetchItem(_, id) {
      const resp = await axiosInstance.get(`/Activities/${id}`);
      return resp;
    },
  },
};

export default module;
