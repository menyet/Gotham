var app = Ember.Application.create();

app.Router.map(function () {
    // put your routes here
});

app.IndexRoute = Ember.Route.extend({
    model: function () {
        //return ['red', 'yellow', 'blue', 'green'];

        var artistObjects = [];
        Ember.$.getJSON('http://localhost:50050/api/Accounts', function (artists) {
            artists.forEach(function (data) {
                artistObjects.pushObject(data.Name + " " + data.Id);
            });
        });
        return artistObjects;


    }
});