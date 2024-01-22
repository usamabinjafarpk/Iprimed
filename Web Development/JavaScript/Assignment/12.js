function countLetters(str) {
    const letterCount = {};
    str.split('').forEach((letter) => {
      if (letterCount[letter]) {
        letterCount[letter]++;
      } else {
        letterCount[letter] = 1;
      }
    });
    return letterCount;
  }
  console.log(countLetters("aasswweee"));