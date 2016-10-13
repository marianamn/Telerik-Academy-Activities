import { clothesFactory } from '../models/clothes-factory.js';
import { Clothing } from '../models/clothing.js';

const expect = require('chai').expect;

const validData = {
    categories: {
        clothes: 'Clothes',
        shoes: 'Shoes',
        hats: 'Hats'
    },
    names: {
        eveningGirl: `Evening girl`,
        suitYou: `Suit you`,
        casualDay: `Casual day`,
        theBeathelsShirt: `The Beathels shirt`,
        summerTimeGirl: `Summer time girl`,
        jeansDay: `Jeans day`,
        beStylish: `Be stylish`,
        academyShirt: `Academy shirt`,
        mustacheMe: `Mustache men`,
        justJeans: `Just jeans`,
        highHeelRules: `High heels rules`,
        tallAndFashion: `Tall and fashion`,
        beSportish: `Be sportish`,
        boots: `Boots`,
        officeWoman: `Office woman`,
        beInBlue: `Be in blue`,
        snowWhite: `Snow-white`,
        sandalsTime: `Sandals time`,
        letsSport: `Lets sport`,
        beComfortable: `Be comfortable`,
        summerBeauty: `Summer beauty`,
        winterCharm: `Winter charm`,
        redHood: `Red hood`,
        oldSchool: `Old school`,
        grannyStyle: `Granny's style`,
        keepEarm: `Keep warm`,
        poloMen: `Polo men`,
        gentlemanHat: `Gentleman hat`,
        weedingHat: `Weeding hat`,
        batmanHat: `Batman hat`,
    },
    genders: {
        men: 'Men',
        women: 'Women'
    },
    prices: [
        99.9,
        120.56,
        60.5,
        15.3,
        50.5,
        56.3,
        80.6,
        51.3,
        10.5,
        21.5,
        78.5,
        85.6,
        70.5,
        75.6,
        100,
        65.3,
        99.5,
        65.4,
        45.6,
        54.3,
        56.8,
        30,
        15,
        20,
        18,
        10,
        11,
        20.5,
        25.35,
        11,
    ],
    availableSizes: [
        `S/M/L`,
        `S/M/L`,
        `S/M/L`,
        `S/M/L`,
        `M/L`,
        `S/M/L`,
        `S/M/L`,
        `S/M/L/XL`,
        `L`,
        `S/M/L`,
        `36/37/38/40`,
        `39/40/41/42/43/44`,
        `36/37/38/39/40`,
        `39/40/41/42/43/44`,
        `36/37/38/39/40`,
        `39/40/41/42/43/44`,
        `36/37/38/39/40`,
        `36/37/38/39/40`,
        `36/37/38/39/40`,
        `36/37/38/39/40`,
        `S/M/L`,
        `S/M/L`,
        `S`,
        `S/M/L`,
        `S/M/L`,
        `M/L`,
        `M/L`,
        `S/M/L`,
        `S/M/L`,
        `M/L`,
    ],
    colors: {
        Blue: `Blue`,
        Perple: `Perple`,
        Gray: `Gray`,
        WhiteAndBlue: `White and blue`,
        Denim: `Denim`,
        WhiteAndBlack: `White and black`,
        Flowering: `Flowering`,
        Beige: `Beige`,
        RedBeigeWhite: `Red/Beige/White`,
        White: `White`,
        Pirple: `Pirple`,
        Brown: `Brown`,
        Plaid: `Plaid`,
        Red: `Red`,
        Green: `Green`,
        Black: `Black`,
    },
    imageURLs: [
        `http://s7d9.scene7.com/is/image/CharlotteRusse/302146969_468?$s7product$&fmt=jpg&fit=constrain,1&wid=290&hei=375`,
        `http://66.media.tumblr.com/16b84775b963340e066f5cb156464335/tumblr_mwnj2fB7Bo1sj7ucfo1_500.png`,
        `http://g01.a.alicdn.com/kf/HTB1e8sXKVXXXXcnXFXXq6xXFXXXA/High-Quality-Men-Shoes-2016-New-Fashionable-Suede-Leather-Shoes-Round-Toe-Casual-Male-Rubber-Shoes.jpg`,
        `https://67.media.tumblr.com/ca802d8e51e5677b662d131121bfa8a2/tumblr_n4dvs3GoQ81t05atmo1_500.jpg`,
        `http://pakistyles.com/wp-content/uploads/2016/02/0ea6cb872787423388450b4305a50124.jpg`,
        `https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTPTApEnrEQ_fj80QuL1vLNzYTt3E2g2kvFwCLj6SzMRub0jgNzUA`,
        `http://www.newstreetstyles.com/wp-content/uploads/2016/05/1.jpg`,
        `https://s.thestreet.com/files/tsc/v2008/photos/contrib/uploads/womenswinterboots_600x400.jpg`,
        `http://a3559z1.americdn.com/wp-content/uploads/2014/07/Top-10-must-have-shoes-for-summer-2014-5.jpg`,
        `https://s-media-cache-ak0.pinimg.com/564x/b2/17/93/b21793c50d292f34065292bdddfdfa8e.jpg`,
        `http://www.befashy.com/wp-content/uploads/2016/08/mens-fashion-shoes-ideas.jpg`,
        `http://www.buyhathats.com/sites/default/files/hat-cap-images/white-floppy-straw-hat-women-wide-brim-sun-hats-summer-beach-wear8971.jpg`,
        `http://www.buytra.com/sites/default/files/wear/14-10/fur-knit-beanie-hats-for-women-fox-ovo-ball-winter-hats-73843.jpg`,
        `http://g01.a.alicdn.com/kf/HTB10rgZIVXXXXcRXFXXq6xXFXXXQ/Elegant-Women-Hat-Winter-Fall-Beanies-Knitted-Hats-For-Woman-Rabbit-Fur-Cap-Autumn-And-Winter.jpg`,
        `http://www.buytra.com/sites/default/files/wear/14-09/cute-bow-beret-hat-wool-winter-hats-women-70455.jpg`,
        `http://www.buytra.com/sites/default/files/wear/14-09/bow-knit-hats-women-winter-hats-hand-woven-71533.jpg`,
        `http://www.buytra.com/sites/default/files/wear/14-09/cheap-hip-hop-knit-hats-men-winter-beanie-hats-71651.jpg`,
        `http://www.taghats.com/wp-content/uploads/2015/04/Flat-Cap-Hats-for-Men.jpg`,
        `https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcQ_Zp9S7YUgG2nZg5u8pyU5TOXDlJkLpalMd5slwAPhEZ17naP7`,
        `http://g01.a.alicdn.com/kf/HTB1K4p8KFXXXXXoXXXXq6xXFXXXd/British-aristocracy-luxury-Organza-sinamay-hats-for-women-ladies-wedding-church-hats-sun-wide-brim-hat.jpg`,
        `https://images.superherostuff.com/image-capbatbkyw3930-primary-watermark.jpg`,
    ]
};

describe('createClothing', () => {
    const category = validData.categories.shoes,
        name = validData.names.boots,
        gender = validData.genders.men,
        price = validData.prices[5],
        availableSizes = validData.availableSizes[16],
        color = validData.colors.Beige,
        imgURL = validData.imageURLs[16];

    it('should create and object which is an instance of the Clothing class', (done) => {
        const clothing = clothesFactory.createClothing(category, name, gender, price, availableSizes, color, imgURL);

        expect(clothing).to.be.instanceof(Clothing);
        done();
    });

    it('should create an object with correct category', (done) => {
        const clothing = clothesFactory.createClothing(category, name, gender, price, availableSizes, color, imgURL);

        expect(clothing.category).to.equal(category);
        done();
    });

    it('should create an object with correct name', (done) => {
        const clothing = clothesFactory.createClothing(category, name, gender, price, availableSizes, color, imgURL);

        expect(clothing.name).to.equal(name);
        done();
    });

    it('should create an object with correct gender', (done) => {
        const clothing = clothesFactory.createClothing(category, name, gender, price, availableSizes, color, imgURL);

        expect(clothing.gender).to.equal(gender);
        done();
    });

    it('should create an object with correct price', (done) => {
        const clothing = clothesFactory.createClothing(category, name, gender, price, availableSizes, color, imgURL);

        expect(clothing.price).to.equal(price);
        done();
    });

    it('should create an object with correct availableSizes', (done) => {
        const clothing = clothesFactory.createClothing(category, name, gender, price, availableSizes, color, imgURL);

        expect(clothing.availableSizes).to.equal(availableSizes);
        done();
    });

    it('should create an object with correct availableSizes', (done) => {
        const clothing = clothesFactory.createClothing(category, name, gender, price, availableSizes, color, imgURL);

        expect(clothing.availableSizes).to.equal(availableSizes);
        done();
    });

    it('should create an object with correct color', (done) => {
        const clothing = clothesFactory.createClothing(category, name, gender, price, availableSizes, color, imgURL);

        expect(clothing.color).to.equal(color);
        done();
    });

    it('should create an object with correct imgURL', (done) => {
        const clothing = clothesFactory.createClothing(category, name, gender, price, availableSizes, color, imgURL);

        expect(clothing.imgURL).to.equal(imgURL);
        done();
    });
});