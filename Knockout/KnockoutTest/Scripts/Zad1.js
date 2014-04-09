var initialData =
        [
            { opis: "first", data: "2012-01-12" },
            { opis: "second", data: "2011-06-19" },
            { opis: "third", data: "2011-10-01" }
        ];

var ViewModel = function () {

    var self = this;

    self.sortEvents = function () {
        return self.events.sort(function (left, right) {
            return left.data == right.data ?
                 0 : (left.data < right.data ? -1 : 1);
        });
    };

    self.date = ko.observable("");
    self.description = ko.observable("");
    self.events = ko.observableArray(initialData);
    self.events(self.sortEvents());

    self.addEvent = function () {
        self.events.push({ opis: self.description(), data: self.date() });
        self.events(self.sortEvents());
    };

    self.removeEvent = function (event) {
        self.events.remove(event);
    };
};

ko.applyBindings(new ViewModel());