'use strict'

// *************************************
// Create Closure for PDSC Functionality
// *************************************
var pdscController = (function () {
  // ************************************
  // Private Variables
  // ************************************
  let searchValues = null;

  // ************************************
  // Private Functions
  // ************************************
  function pleaseWait(ctl) {
    // Was a control passed in?
    if (ctl) {
      // Look for a data-waitmsg="message"
      // on the control clicked on
      let msg = $(ctl).data("waitmsg");
      if (msg) {
        $("#theWaitMessage").html(msg);
      }
    }

    $("#pleaseWait").removeClass("d-none");
    $("header").addClass("pleaseWaitArea");
    $("main").addClass("pleaseWaitArea");
    $("footer").addClass("pleaseWaitArea");

    disableAllClicks();

    return true;
  }

  function disableAllClicks() {
    // Change all link cursors to an arrow and
    // disable all click events
    $("a").css("cursor", "arrow").click(false);
    // Disable all <input type="button"> elements
    $("input[type='button']").attr("disabled", "disabled");
    // Disable all <button> elements
    $("button").attr("disabled", "disabled");
  }

  function setSearchValues(value) {
    searchValues = value;
  }

  function isSearchFilledIn() {
    return searchValues;
  }

  function setSearchArea() {
    $("#searchBody").collapse(isSearchFilledIn() ? "show" : "hide");
  }

  function sortOnHeaderClick(sortField) {
    $("#SortExpression").val(sortField);

    $("form").submit();
  }

  function pageOnClick(command) {
    $("#PageCommand").val(command);

    $("form").submit();
  }

  function formSubmit() {
    $("form").submit(function () {
      if ($("form").valid()) {
        pleaseWait(this);
      }
    });
  }

  // ************************************
  // Public Functions
  // ************************************
  return {
    "pleaseWait": pleaseWait,
    "disableAllClicks": disableAllClicks,
    "setSearchValues": setSearchValues,
    "isSearchFilledIn": isSearchFilledIn,
    "setSearchArea": setSearchArea,
    "sortOnHeaderClick": sortOnHeaderClick,
    "pageOnClick": pageOnClick,
    "formSubmit": formSubmit
  }
})();