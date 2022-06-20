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
      aspectRatio: {
        '5/7': '5 / 7',
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
