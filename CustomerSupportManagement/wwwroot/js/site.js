// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function loadDropdown(dropdownElement, url, placeholderText = '-- Select --', selectedValue = 0) {
    var dropdownControl = $(dropdownElement);
    $.ajax({
        url: url,
        method: 'GET',
        success: function (data) {
            dropdownControl.empty();
            dropdownControl.append($('<option>', {
                value: '',
                text: placeholderText
            }));
            $.each(data, function (index, item) {
                dropdownControl.append($('<option>', {
                    value: item.value,
                    text: item.text
                }));
            });
            if (selectedValue !== 0) {
                dropdownControl.val(selectedValue);
            }
            dropdownControl.trigger('chosen:updated');
            getLoader(false);
        },
        error: function (error) {
            console.error('Error:', error);
            getLoader(false);
        }
    });
}
