// eslint-disable-next-line import/prefer-default-export
export const toTurkishUpper = (s) => {
  let upper = s;
  const letters = {
    i: 'İ', ş: 'Ş', ğ: 'Ğ', ü: 'Ü', ö: 'Ö', ç: 'Ç', ı: 'I',
  };
  upper = upper.replace(/(([iışğüçö]))/g, (letter) => letters[letter]);
  return upper.toUpperCase();
};

export const formatter = new Intl.NumberFormat('tr-TR', {
  style: 'currency',
  currency: 'TRY',
});
