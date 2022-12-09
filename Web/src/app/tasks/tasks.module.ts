import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TasksRoutingModule } from './tasks-routing.module';
import { TasksComponent } from './tasks.component';
import { TasksService } from './tasks.service';
import { HttpClientModule } from '@angular/common/http';
import { TaskUpsertDialogComponent } from './task-upsert-dialog/task-upsert-dialog.component';
import { MatDialogModule } from '@angular/material/dialog';
import { ReactiveFormsModule } from '@angular/forms';
import { TaskFormService } from './task-form.service';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatInputModule } from '@angular/material/input';
import { MatButtonModule } from '@angular/material/button';



@NgModule({
  declarations: [
    TasksComponent,
    TaskUpsertDialogComponent
  ],
  imports: [
    CommonModule,
    TasksRoutingModule,
    HttpClientModule,
    MatDialogModule,
    ReactiveFormsModule,
    MatFormFieldModule,
    MatInputModule,
    MatButtonModule
  ],
  providers: [TasksService, TaskFormService]
})
export class TasksModule { }
