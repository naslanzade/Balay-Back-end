$(document).ready(function () {
  //The wowjs
  new WOW().init();

  //Sidebar
  let filterBar = document.querySelector("#filter-for-phone .all");
  let settingsButton = document.querySelector("#settings .all .button");

  settingsButton.addEventListener("click", function () {
    if (filterBar.classList.contains("hide-filter")) {
      filterBar.classList.add("active-filter");
      filterBar.classList.remove("hide-filter");
      settingsButton.classList.add("slide-settings");
    } else {
      filterBar.classList.remove("active-filter");
      filterBar.classList.add("hide-filter");
      settingsButton.classList.remove("slide-settings");
    }
  });


});
