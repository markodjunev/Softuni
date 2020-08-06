import { showError, showInfo } from '../notification.js';
import { register, checkResult, login, logout as apiLogout } from '../data.js';

export async function registerPage() {
    this.partials = {
        header: await this.load('./templates/common/header.hbs'),
        footer: await this.load('./templates/common/footer.hbs')
    };

    this.partial('./templates/user/register.hbs');
}

export async function loginPage() {
    this.partials = {
        header: await this.load('./templates/common/header.hbs'),
        footer: await this.load('./templates/common/footer.hbs')
    };

    this.partial('./templates/user/login.hbs');
}

export async function logout() {
    try {
        await apiLogout();

        this.app.userData.username = '';
        this.app.userData.userId = '';
        this.app.userData.names = '';


        showInfo('Logout successful');
        this.redirect('#/home');
    } catch (err) {
        showError(err.message);
    }
}

export async function registerPost() {
    try {
        if (this.params.firstName.length < 2) {
            throw new Error('First name must be at least 2 characters.');
        }
        if (this.params.lastName.length < 2) {
            throw new Error('Last name must be at least 2 characters.');
        }
        if (this.params.username.length < 3) {
            throw new Error('The username must be at least 3 characters.');
        }
        if (this.params.password.length < 6) {
            throw new Error('The password must be at least 6 characters.');
        }

        if (this.params.password !== this.params.repeatPassword) {
            throw new Error('Password don\'t match');
        }

        const result = await register(
            this.params.firstName,
            this.params.lastName,
            this.params.username,
            this.params.password
        );

        checkResult(result);

        const loginResult = await login(this.params.username, this.params.password);

        checkResult(loginResult);

        this.app.userData.username = loginResult.username;
        this.app.userData.userId = loginResult.objectId;
        this.app.userData.names = `${loginResult.firstName} ${loginResult.lastName}`;


        showInfo('User registration successful');
        this.redirect('#/home');
    } catch (err) {
        showError(err.message);
        console.log(err.message);
    }
}

export async function loginPost() {
    try {
        const result = await login(
            this.params.username,
            this.params.password
        );

        checkResult(result);

        this.app.userData.username = result.username;
        this.app.userData.userId = result.objectId;
        this.app.userData.names = `${result.firstName} ${result.lastName}`;

        showInfo('Login successful');
        this.redirect('#/home');
    } catch (err) {
        showError(err.message);
        console.log(err.message);
    }
}