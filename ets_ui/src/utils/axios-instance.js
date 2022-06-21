import axios from 'axios';

export default axios.create({
  baseURL: 'http://test.miyoshop.com',
  // baseURL: 'https://localhost:44340',
});
