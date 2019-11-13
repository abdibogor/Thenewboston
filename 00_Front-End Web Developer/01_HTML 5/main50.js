function doFirst(){
		var button = document.getElementByID("button");
		button.addEventListener("load", saveCrap, false);
}
function saveCrap{
		var one = document.getElementById("one").value;
		var two = document.getElementById("two").value;
		sessionStorage.setItem(one,two);
		
		
}
window.addEventListener("load", doFirst, false)