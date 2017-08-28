/**
 * @author Batch Themes Ltd.
 */
(function() {
    'use strict';
    $(function() {
        var config = $.localStorage.get('config');
        $('body').attr('data-layout', 'fullsize-background-image');
        $('body').attr('data-palette', config.theme);
        $('body').attr('data-direction', config.direction);
        var email = $('.login-page #email');
        email.floatingLabels({
            errorBlock: 'Por favor ingrese su usuario',
        });
        var password = $('.login-page #password');
        password.floatingLabels({
            errorBlock: 'Por favor ingrese un password correcto',
            minLength: 6
        });
        $('.login-page .btn-login').click(function(e) {
            e.preventDefault();
            return false;
        });
    });
})();
