import { Clothing } from './clothing.js';

const factory = {
    createClothing: function (category, name, gender, price, availableSize, color, imgURL) {
        return new Clothing(category, name, gender, price, availableSize, color, imgURL);
    }
};

export { factory as clothesFactory };
