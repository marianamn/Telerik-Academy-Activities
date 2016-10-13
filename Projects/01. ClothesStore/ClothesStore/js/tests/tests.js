mocha.setup('bdd');

const {expect, assert} = chai;

const AUTH_KEY = "SOME_AUTH_KEY";
const user = {
	username: 'SOME_USERNAME',
	password: 'SOME_PASSHASH'
};

describe('Dress Tests', function () {
	describe('Register Tests', function () {

		beforeEach(function () {
			sinon.stub(requester, 'postJSON')
				.returns(new Promise((resolve, reject) => {
					resolve(user);
				}));
		});

		afterEach(function () {
			requester.postJSON.restore();
		});

		it('expect postJSON to be called once', function (done) {
			data.register(user)
				.then(() => {
					expect(requester.postJSON.calledOnce).to.be.true;
				})
				.then(done, done);
		});

		it('expect data.register() to make correct postJSON call', function (done) {
			data.register(user)
				.then(() => {
					const actual = requester.postJSON
						.firstCall
						.args[0];
						console.log(requester.postJSON.firstCall.args);
					expect(actual).to.equal('https://baas.kinvey.com/user/kid_ByJ1lcL6');
				})
				.then(done, done);
		});
		it('expect data.register() to post correct user data', function (done) {
			data.register(user)
				.then(() => {
					const actual = requester.postJSON
						.firstCall
						.args[1];
					const prop = Object.keys(actual).sort();
					expect(prop.length).to.equal(2);
					expect(prop[0]).to.equal('password');
					expect(prop[1]).to.equal('username');
				})
				.then(done, done);
		});

		it('expect registering of user to return the user', function (done) {
			data.register(user)
				.then(actual => {
					expect(actual).to.eql(user);
				})
				.then(done, done);
		});
	});
});

mocha.run();

