export interface Task {
    id?: number;
    name: string;
    description: string;
    createdDate: string;
    priority: number;
    status: TaskStatus
}
export enum TaskStatus
    {
        New,
        InProgress,
        Testing,
        Closed
    }
