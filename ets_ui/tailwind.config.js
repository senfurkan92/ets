module.exports = {
  content: [
    './index.html',
    './src/**/*.{vue,js,ts,jsx,tsx}',
  ],
  theme: {
    extend: {
      fontFamily: {
        navigation: ['Bebas Neue'],
        title: ['Anton'],
      },
    },
  },
  plugins: [
    // eslint-disable-next-line global-require
    require('daisyui'),
  ],
  daisyui: {
    themes: ['night', 'winter'],
  },
};
