function findLongestWord(str) {
    return str.split(' ').reduce(function(longest, currentWord) {
      return currentWord.length > longest.length ? currentWord : longest;
    }, '');
  }
  console.log(findLongestWord("Web Development Tutorial"));