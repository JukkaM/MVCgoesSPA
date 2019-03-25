export class Spa {
    Name: string;
    DayTicketPrice: number;
    WeekEndTicketPrice: number;
    Visitors: Visitor[];
}

export class Visitor {
    FirstName: string;
    LastName: string;
    Phone: string;
    Email: string;
    VisitTime: string;
    FeedbackRate?: number;
}