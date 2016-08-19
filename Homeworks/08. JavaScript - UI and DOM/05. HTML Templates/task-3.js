function solve(){
  return function(){
$.fn.listview = function(data) {
                    var id,
                        template,
                        html,
                        i,
                        len;

                    var $this = $(this);
                    id = '#' + $this.attr('data-template');
                    template = $(id).html();
                    html = handlebars.compile(template);
                    data.forEach(function (item) {
                        $this.append(html(item));
                    });
		};
    };
}
module.exports = solve;