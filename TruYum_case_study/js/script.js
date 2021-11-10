function validation() {
    var title = document.getElementById("title").value.trim();
    var price = document.getElementById("price").value.trim();
    var dateOfLaunch = document.getElementById("dateOfLaunch").value;
    var inStock = document.getElementsByName("inStock");
    if (price == "") {
        alert("Please enter the Price.");
        return false;
    }
    if (!price.match(/^\d+$/)) {
        alert("Price has to be a number");
        return false;
    }

    if (title == "") {
        alert("Please enter the Title.");
        return false;
    }
    if (!(title.length > 1 && title.length < 66)) {
        alert("The Title should have 2 to 65 characters!");
        return false;
    }

    if (dateOfLaunch == "") {
        alert("Please enter the Date!");
        return false;
    }
    isChecked = false;

    for (let i = 0; i < inStock.length; i++) {
        if (inStock[i].checked == true) {
            isChecked = true;
        }
    }
    if (isChecked == false) {
        alert("Please enter In Stock status!");
        return false;
    } else {
        location.href = "edit-menu-item-status.html";
    }
    return false;
}