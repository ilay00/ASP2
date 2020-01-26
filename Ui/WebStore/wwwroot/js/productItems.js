ProductItems = {
    _options: {
        getUrl: ''
    },
    init: function (options)
    {
        $.extend(ProductItems, options, options);
        $('.paginagion li').on('click', ProductItems.clickOnPage);
    }
    clickOnPage: function (event) {
        event.preventDefault();
        if ($(this).prop('href').length > 0) {
            var page = $(this).data('page');
            $('#itemsContainer').LoadingOverlay('show');
            var data = $(this).data();
            var quer = '';
            for (var key in data) {
                if (data.hasOwnProperty(key)) {
                    quer += key + '=' + data[key] + '&';

                }
            }
            //Делаим запрос на сервир
            $.get(ProductItems._options.getUrl + '?' + query)
                .done(function (result) {
                    $('#itemsContainer').html(result);
                    $('#itemsContainer').LoadingOverlay('hide');
                    //Обновляим пейджинг
                    $('.pagination li').removeClass('active');
                    $('.pagination li a').prop('href', '#');
                    $('.pagination li a[data-page=' + page + ']')
                    removeAttr('href')
                    parent()
                    addClass('active');
                })
                .fail(function () {
                    console.log('clickOnPage getItems error');
                    $('#itemsContainer').LoadingOverlay('hide');
                });
        }
    }
}