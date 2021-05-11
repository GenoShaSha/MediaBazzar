﻿ var dp = new DayPilot.Calendar("dp");

        // view
        dp.startDate = "2021-03-25";
        dp.viewType = "Week";

        // event creating
        dp.onTimeRangeSelected = function (args) {
            var name = prompt("New event name:", "Event");
            if (!name) return;
            var e = new DayPilot.Event({
                start: args.start,
                end: args.end,
                id: DayPilot.guid(),
                text: name
            });
            dp.events.add(e);
            dp.clearSelection();
        };

        dp.onEventClick = function (args) {
            alert("clicked: " + args.e.id());
        };

        dp.headerDateFormat = "dddd";
        dp.init();

        var monday = new DayPilot.Event({
            start: new DayPilot.Date("2021-03-22T09:00:00"),
            end: new DayPilot.Date("2021-03-22T09:00:00").addHours(3).addMinutes(30),
            id: "1",
            text: "Special event"
            
        });
        dp.events.add(monday);