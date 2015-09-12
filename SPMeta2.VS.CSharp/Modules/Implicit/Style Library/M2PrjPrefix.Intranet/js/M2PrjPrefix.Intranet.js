
jQuery(document).ready(function () {
    console.log('jQuery was initialized.');

    // hiding recent stuff :)
    jQuery(".ms-core-listMenu-item:contains('Recent')").parent().hide();
});