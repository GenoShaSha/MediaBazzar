 
 var dp = new DayPilot.Calendar("dp");

        dp.startDate = "2021-05-10";
        dp.viewType = "Week";
        var username = document.getElementById("userName").value;

        var userShiftType = document.getElementById("userShiftType").value;
        var userShiftDate = document.getElementById("userShiftDate").value;

        var startTime;
        var endTime;

        if(userShiftType == "Morning")
        {
            startTime = "T12:00:00";
            endTime= "T13:00:00"
        }    
        if(userShiftType == "Afternoon")
        {
            startTime = "T12:00:00";
            endTime= "T17:00:00"
        }
        if(userShiftType == "Night")
        {
            startTime = "T17:00:00";
            endTime= "T21:00:00"
        }

        dp.onEventClick = function (args) {
            alert("Start Shift: " + args.e.start() + "\n" + "End Shift: " + args.e.end() + "\n" +"Employee: "+ username );
        };

        dp.headerDateFormat = "dddd";
        dp.init();

        var monday = new DayPilot.Event({
            start: new DayPilot.Date(userShiftDate+startTime),
            end: new DayPilot.Date(userShiftDate+endTime),
            id: "1",
            text: "Monday Shift"
        });
        /*
        var tuesday = new DayPilot.Event({
            start: new DayPilot.Date(userShiftDate+startTime),
            end: new DayPilot.Date(userShiftDate+endTime),
            id: "2",
            text: "Tuesday Shift"
            
        });
        var wednesday = new DayPilot.Event({
            start: new DayPilot.Date(userShiftDate+startTime),
            end: new DayPilot.Date(userShiftDate+endTime),
            id: "3",
            text: "Wednesday Shift"
            
        });
        var thursday = new DayPilot.Event({
            start: new DayPilot.Date(userShiftDate+startTime),
            end: new DayPilot.Date(userShiftDate+endTime),
            id: "4",
            text: "Thursday Shift"
            
        });
        var friday = new DayPilot.Event({
            start: new DayPilot.Date(userShiftDate+startTime),
            end: new DayPilot.Date(userShiftDate+endTime),
            id: "5",
            text: "Friday Shift"
            
        });
        */
        dp.events.add(monday);
        /*
        dp.events.add(tuesday);
        dp.events.add(wednesday);
        dp.events.add(thursday);
        dp.events.add(friday);
        */
      