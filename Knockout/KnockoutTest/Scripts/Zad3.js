var Value = function () {
    this.wartosc = ko.observable();
};

var ViewModel = function () {
    var self = this;
    self.tablica = ko.observableArray([new Value()]);

    self.addItem = function () {
        self.tablica.push(new Value());
    };

    self.removeItem = function (item) {
        self.tablica.remove(item);
    };

    self.sum = ko.computed(function () {
        var total = 0;
        $.each(self.tablica(), function () { total += this.wartosc() ? parseInt(this.wartosc(), 10) : 0; })
        return total;
    });

    self.displaySum = ko.computed(function () {
        return "Suma z " + self.tablica().length + " liczb wynosi: " + self.sum();
    });
};

ko.applyBindings(new ViewModel());