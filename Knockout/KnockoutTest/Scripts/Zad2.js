var ViewModel = function () {
    this.temp = ko.observable(0);

    this.increase = function () {
        this.temp(this.temp() + 20);
    };
    this.decrease = function () {
        this.temp(this.temp() - 20);
    };

    this.message = function () {
        return "Aktualna temperatura rdzenia: " + this.temp();
    };
};

ko.applyBindings(new ViewModel());