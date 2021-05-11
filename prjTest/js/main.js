 var dp = new DayPilot.Calendar("dp");

        dp.startDate = "2021-05-10";
        dp.viewType = "Week";


        dp.onEventClick = function (args) {
            alert("Start Shift: " + args.e.start() + "\n" + "End Shift: " + args.e.end() + "\n" +"Employee: Jordy" );
        };

        dp.headerDateFormat = "dddd";
        dp.init();

        var monday = new DayPilot.Event({
            start: new DayPilot.Date("2021-05-10T09:00:00"),
            end: new DayPilot.Date("2021-05-10T18:00:00"),
            id: "1",
            text: "Morning & Afternoon Shift"
        });
        var tuesday = new DayPilot.Event({
            start: new DayPilot.Date("2021-05-11T09:00:00"),
            end: new DayPilot.Date("2021-05-11T12:00:00"),
            id: "2",
            text: "Morning Shift"
            
        });
        var wednesday = new DayPilot.Event({
            start: new DayPilot.Date("2021-05-12T12:00:00"),
            end: new DayPilot.Date("2021-05-12T20:00:00"),
            id: "3",
            text: "Evening Shift"
            
        });
        var thursday = new DayPilot.Event({
            start: new DayPilot.Date("2021-05-13T09:00:00"),
            end: new DayPilot.Date("2021-05-13T18:00:00"),
            id: "3",
            text: "Morning & Afternoon Shift"
            
        });
        var friday = new DayPilot.Event({
            start: new DayPilot.Date("2021-05-14T12:00:00"),
            end: new DayPilot.Date("2021-05-14T20:00:00"),
            id: "3",
            text: "Evening Shift"
            
        });
        dp.events.add(monday);
        dp.events.add(tuesday);
        dp.events.add(wednesday);
        dp.events.add(thursday);
        dp.events.add(friday);


