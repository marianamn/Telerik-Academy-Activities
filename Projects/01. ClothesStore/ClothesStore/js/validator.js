var validator = (function() {

  function validateUsername(str, min, max, chars) {
    if (typeof str !== 'string' || str.length < min || str.length > max) {
      return {
        message: `Username must be between ${min} and ${max} symbols`
      };
    }
    if (chars) {
      str = str.split('');
      if (str.some(function(char) {
          return chars.indexOf(char) < 0;
        })) {
        return {
          message: `Invalid: Chars can be ${chars}`
        };
      }
    }
  }

  function validatePassword(str, min, max) {
    if (typeof str !== 'string' || str.length < min || str.length > max) {
      return {
        message: `Password must be between ${min} and ${max} symbols`
      };
    }
  }

  return {
    validateUsername: validateUsername,
    validatePassword: validatePassword
  };
}());