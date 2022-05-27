// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your Javascript code.

function checkCategory() { // function that hide/show extra fields for subcategory
    var category = document.getElementById("category");
    var selectedValue = category.options[category.selectedIndex].value;
    
    if (selectedValue == 2) { // business
        document.getElementById("subcategory").removeAttribute("hidden");
        document.getElementById("othercategory").setAttribute("hidden", true);
    }
    else if (selectedValue == 3) { // other
        document.getElementById("subcategory").setAttribute("hidden", true);
        document.getElementById("othercategory").removeAttribute("hidden");
    }
    else { // private
        document.getElementById("subcategory").setAttribute("hidden", true);
        document.getElementById("othercategory").setAttribute("hidden", true);
    }
}

function registrationValidate() {
    var pwds = [];
    var inputs = document.getElementsByTagName("input");
    for (var i = 0; i < inputs.length; i++) {
        if (inputs[i].type.toLowerCase() === "password") {
            pwds.push(inputs[i]);
        }
    }

    if (pwds[0].value != pwds[1].value) {
        alert("Hasła nie są identyczne");
        return false;
    }
    if (!checkPassword(pwds[0].value))
        return false;

    return true;
}

function checkPassword(p1) {
    if (p1.length < 8) {
        alert("Hasło jest za krótkie");
        return false;
    }

    if (!containsNumber(p1) || p1.toLowerCase() == p1 || p1.toUpperCase() == p1) {
        alert("Hasło musi zawierać małe i duże litery oraz cyfry")
        return false;
    }

    return true;
}

function containsNumber(pass) { // check if string contains digit in it
    for (var i = 0; i < pass.length; ++i) {
        var char = pass[i];
        if (!isNaN(char)) {
            return true;
        }
    }
    return false;
}