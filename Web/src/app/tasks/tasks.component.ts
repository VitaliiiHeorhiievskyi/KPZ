import { Component, OnDestroy, OnInit } from '@angular/core';
import { Observable, skipWhile, Subject, switchMap, takeUntil } from 'rxjs';
import { TaskFormService } from './task-form.service';
import { Task, TaskStatus } from './tasks.model';
import { FormGroup } from '@angular/forms';
import { MatDialog } from '@angular/material/dialog';
import { TaskUpsertDialogComponent } from './task-upsert-dialog/task-upsert-dialog.component';
import { TasksService } from './tasks.service';

@Component({
  selector: 'app-tasks',
  templateUrl: './tasks.component.html',
  styleUrls: ['./tasks.component.scss']
})
export class TasksComponent implements OnInit, OnDestroy {
  public tasks$!: Observable<Task[]>;
  public form!: FormGroup;
  public Status = TaskStatus;
  public searchTerm = '';
  private destroy$ = new Subject<void>();

  constructor(private formService: TaskFormService,
    private dialog: MatDialog,
    private tasksService: TasksService){}

  public ngOnInit(): void {
    this.tasks$ = this.tasksService.getTasks().pipe(takeUntil(this.destroy$))
  }

  public ngOnDestroy(): void {
    this.destroy$.next();
    this.destroy$.complete();
  }

  public openDialog(task?: Task): void {
    if (task === undefined) {
      this.formService.initForm();
    } else {
      this.formService.initForm(task);
    }
    this.form = this.formService.form;

    const dialogRef = this.dialog.open(TaskUpsertDialogComponent, {
      data: {
        form: this.form,
      },
      autoFocus: false,
    });

    dialogRef
      .afterClosed()
      .pipe(
        takeUntil(this.destroy$),
        skipWhile((result) => result === undefined || !result.isSubmit),
      )
      .subscribe(() => {
        this.upsertTask(task?.id);
      });
  }

  private upsertTask(id?: number): void {
    let data = this.formService.prepareData();

    let updatedTask: Task = {
      id: id,
      name: data.name,
      description: data.description,
      createdDate: new Date(data.createdDate).toISOString(),
      priority: data.priority,
      status: data.status
    };

    let upsert$: Observable<Object>;
    if (id === undefined) {
      upsert$ = this.tasksService.createTask(updatedTask);
    } else {
      upsert$ = this.tasksService.editTask(updatedTask);
    }

    upsert$
      .pipe(
        takeUntil(this.destroy$),
      )
      .subscribe(() =>{
        this.tasks$ = this.tasksService.getTasks().pipe(takeUntil(this.destroy$))
      });
  }

  public search(searchTerm:any): void{
    this.searchTerm = searchTerm.target.value;
    if(this.searchTerm)
    {
      this.tasks$ = this.tasksService.search(this.searchTerm).pipe(takeUntil(this.destroy$));
    }
    else {
      this.tasks$ = this.tasksService.getTasks().pipe(takeUntil(this.destroy$));
    }
  }

  public deleteTask(id: number): void {
    this.tasksService
      .deleteTask(id)
      .pipe(
        takeUntil(this.destroy$),
      )
      .subscribe(() => {
        this.tasks$ = this.tasksService.getTasks().pipe(takeUntil(this.destroy$))
      });
  }
}
