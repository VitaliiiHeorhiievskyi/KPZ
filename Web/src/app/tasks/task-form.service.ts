import { Injectable } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { Task, TaskStatus } from './tasks.model';
@Injectable()
export class TaskFormService {
  public form!: FormGroup;

  public initForm(task?: Task): void {
    const form = new FormGroup({
      name: new FormControl(task?.name || '', [Validators.required]),
      description: new FormControl(task?.description || '', [Validators.required]),
      createdDate: new FormControl((new Date(task?.createdDate as string)).toLocaleDateString() || null, [Validators.required]),
      priority: new FormControl(task?.priority || '', [Validators.required]),
      status: new FormControl(task?.status || '', [Validators.required]),
    });

    this.form = form;
  }

  public prepareData(): Task {
    const value = this.form.value;

    let data: Task = {
      name: value.name,
      description: value.description,
      createdDate: value.createdDate,
      priority: value.priority,
      status: TaskStatus.Testing
      }

    return data;
  }
}

