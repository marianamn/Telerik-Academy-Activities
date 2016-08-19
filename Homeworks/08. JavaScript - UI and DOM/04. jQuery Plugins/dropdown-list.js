function solve() {
            return function (selector) {
                var container,
                    options,
                    newDiv,
                    i,
                    len;

                container = $('<div />')
                    .addClass('dropdown-list');

                options = $(selector)
                   .find('option');

                newDiv = $('<div />')
                    .addClass('options-container')
                    .css({
                        'position': 'absolute',
                        'display': 'none'
                    });

                $(selector).css('display', 'none').appendTo(container);

                $('<div class="current" data-value="">Option 1</div>').appendTo(container);

                for (i = 0, len = options.length; i < len; i += 1) {
                    var innerDivs = $('<div class="dropdown-item" data-value="' + (i + 1) + '" data-index="' + (i + 1) + '">Option' + (i + 1) + '</div>').addClass('dropdown-item');

                    innerDivs.appendTo(newDiv);
                }

                newDiv.appendTo(container);

                $(document.body).append(container);

                $('.current').on('click', function () {
                    newDiv.css('display', 'block');
                    $(this).html('Select a value');
                });

                newDiv.on('click', '.dropdown-item', function () {
                    newDiv.css('display', 'none');
                    $(selector).val($(this).attr('data-value'));
                    $('.current').html($(this).html());
                });
            };
        }

module.exports = solve;