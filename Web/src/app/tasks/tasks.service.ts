import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable, map } from 'rxjs';
import { environment } from 'src/environments/environment';
import { Task } from './tasks.model';

@Injectable()
export class TasksService {
  private apiUrl = environment.apiUrl + "/ProjectTasks";

  constructor(private httpClient: HttpClient) {}

  public getTasks(): Observable<Task[]> {
    return this.httpClient.get<Task[]>(this.apiUrl);
  }

  public search(searchTerm: string): Observable<Task[]> {
    return this.httpClient.get<Task[]>(this.apiUrl+'/search/'+searchTerm);
  }

  public editTask(updatedTask: Task): Observable<number> {
    return this.httpClient.put<number>(this.apiUrl, updatedTask);
  }

  public createTask(newTask: Task): Observable<number> {
    return this.httpClient.post<number>(this.apiUrl, newTask);
  }

  public deleteTask(id: number): Observable<void> {
    return this.httpClient.delete<void>(`${this.apiUrl}/${id}`);
  }
}

