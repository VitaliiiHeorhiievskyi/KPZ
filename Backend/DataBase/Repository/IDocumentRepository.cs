﻿using WebApi.Models;
using WebApi.Models.Enums;
using WebApi.ViewModels;

namespace WebApi.DataBase.Repository
{
    public interface IDocumentRepository
    {
        Task ChangeStatusAsync(Guid id, NotificationStatusEnum notificationStatus);
        Task<Document> CreateAsync(DocumentViewModel document, string url);
        Task DeleteAsync(Guid id);
        Task<IEnumerable<Document>> GetAllByPatientIdAsync(Guid patientId);
    }
}