function buy(name) {
    let table = document.querySelector("#cart tbody");
    let tableRow = table.insertRow();
    
    let productName = tableRow.insertCell(0);
    productName.innerHTML = name;

    let price = tableRow.insertCell(1);
    price.innerHTML = document.querySelector('#' + name.replace(' ', '') + ' .price').innerHTML;

    let quantity = tableRow.insertCell(2);
    quantity.innerHTML = document.querySelector('#' + name.replace(' ', '') + ' input').value;

    let subTotal = tableRow.insertCell(3);
    subTotal.innerHTML = document.querySelector('#' + name.replace(' ', '') + ' input').value * document.querySelector('#' + name.replace(' ', '') + ' .price').innerHTML.replace('$', '');

    document.querySelector('#' + name.replace(' ', '') + ' input').value = '';
    document.querySelector('#empty').innerHTML = '';
}
function checkout()
{
    alert("thanks for your patronage!");
    document.querySelectorAll("#cart tbody tr").forEach(row => row.remove());
    document.querySelector('#empty').innerHTML = 'No Items in cart';
}