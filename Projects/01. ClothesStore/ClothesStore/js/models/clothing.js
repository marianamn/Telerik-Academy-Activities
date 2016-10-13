class Clothing {
    constructor(category, name, gender, price, availableSizes, color, imgURL) {
        this.category = category;
        this.name = name;
	    this.gender = gender;
        this.price = price;
        this.availableSizes = availableSizes;
        this.color = color;
        this.imgURL = imgURL;
    }

    get category() {
        return this._category;
    }
    
    set category(category) {
        const categoryRegex = /^[a-zA-z]+$/g;

        if (!category || !categoryRegex.test(category)) {
            throw new Error('Incorrect category.');
        }

        this._category = category;
    }

    get name() {
        return this._name;
    }
    
    set name(name) {
        const nameRegex = /^[\w\s\-']+$/g;

        if (!name || !nameRegex.test(name)) {
            throw new Error('Incorrect name.');
        }

        this._name = name;
    }

    get gender() {
        return this._gender;
    }
    
    set gender(gender) {
        if (!gender || (gender !== 'Men' && gender !== 'Women')) {
            throw new Error('Incorrect gender.');
        }

        this._gender = gender;
    }

    get price() {
        return this._price;
    }

    set price(price) {
        if (!price || typeof price !== 'number' || price <= 0) {
            throw new Error('Incorrect price.');
        }

        this._price = price;
    }

    get availableSizes() {
        return this._size;
    }

    set availableSizes(size) {
        const sizeRegex = /^[\w\-\.\/]+$/g;

        if (!size || !sizeRegex.test(size)) {
            throw new Error('Incorrect size.');
        }

        this._size = size;
    }

    get color() {
        return this._color;
    }
    
    set color(color) {
        const colorRegex = /^[a-zA-Z]+$/g;

        if (!color || !colorRegex.test(color)) {
            throw new Error('Incorrect color.');
        }

        this._color = color;
    }

    get imageURL() {
        return this._imageURL;
    }

    set imageURL(imageURL) {
        if (!imageURL) {
            throw new Error('Incorrect image URL.');
        }

        this._imageURL = imageURL;
    }
}

export { Clothing };
