$(document).ready(function () {
    $('.sortable').click(function () {
        var list = $(this).parent().find('ul');
        var listItems = list.find('li').get();

        var sortAscending = $(this).data('sort') !== 'desc';

        listItems.sort(function (a, b) {
            var textA = $(a).text().toUpperCase();
            var textB = $(b).text().toUpperCase();

            return sortAscending ? (textA > textB) ? 1 : (textA < textB) ? -1 : 0
                : (textA < textB) ? 1 : (textA > textB) ? -1 : 0;
        });

        $.each(listItems, function (index, item) {
            list.append(item);
        });

        $(this).data('sort', sortAscending ? 'desc' : 'asc');
    });
});