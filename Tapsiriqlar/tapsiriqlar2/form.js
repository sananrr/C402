document.addEventListener('DOMContentLoaded', function () {
    const form = document.querySelector('.form');
    const clearbtn = document.querySelector('.clear');
    const database = [];

    form.addEventListener('submit', function (e) {
        e.preventDefault();

        const name = form.querySelector('.name').value;
        const surname = form.querySelector('.surname').value;
        const age = parseInt(form.querySelector('.age').value);
        const password = form.querySelector('.password').value;
        const email = form.querySelector('.email').value;
        const gender = form.querySelector('.gender').value;
        const hobbi = form.querySelector('.hobbi').value;

        // Validation 
        if (age < 18) {
            alert('18 yaşdan yuxarı şəxslər qeydiyyatdan keçə bilər.');
            return;
        }

        if (name.length < 3) {
            alert('Adınız ən azı 3 hərfdən ibarət olmalıdır.');
            return;
        }

        if (surname.length < 3) {
            alert('Soyadınız ən azı 3 hərfdən ibarət olmalıdır.');
            return;
        }

        const user = {
            name,
            surname,
            age,
            password,
            email,
            gender,
            hobbi ,
        };

        database.push(user);

        console.log (user);

        // inputların təmizlənməsi
        form.reset();
    });

    clearbtn.addEventListener('click', function () {
        form.reset();
    });

    // konsolda görünməsi üçün
    function displayobj() {
        for (const user of database) {
            console.log(user);
        }
    }

    
    function displayname() {
        for (const user of database) {
            console.log(user.name);
        }
    }

    function displayfname() {
        for (const user of database) {
            console.log(`${user.name} ${user.surname}`);
        }
    }

  
    function numbers(num1, num2) {
        console.log(`Cəm: ${num1 + num2}`);
        console.log(`Fərq: ${num1 - num2}`);
        console.log(`Hasil: ${num1 * num2}`);
        console.log(`Qismət: ${num1 / num2}`);
    }

    
    function operations2(num) {
        if (num % 2 === 0) {
            console.log(`${num} cütdür.`);
        } else {
            console.log(`${num} təkdir.`);
        }
    }

    
    displayobj();
    displayname();
    displayfname();
    numbers(10, 5);
    operations2(7);
});
