DECLARE queueCounter AS INTEGER = 1

WHEN CLINIC_QUEUE is clicked
BEGIN CLINIC_QUEUE
    INPUT PatientName
    INPUT Age
    INPUT ReasonForVisit
    INPUT PatientType

    IF PatientName is empty OR Age is empty OR PatientType has no selection THEN
        DISPLAY "Please fill out all fields."
        RETURN
    ENDIF

    IF Age is not a valid whole number OR Age < 0 OR Age > 120 THEN
        DISPLAY "Please enter a valid age."
        RETURN
    ENDIF

    DECLARE queueString AS STRING
    SET queueString = "Q" + FORMAT(queueCounter, "000")

    DECLARE priorityText AS STRING
    DECLARE patientType AS STRING
    SET patientType = PatientType.SelectedItem

    SWITCH patientType
        CASE "Emergency":
            SET priorityText = "EMERGENCY"
        CASE "Senior":
            SET priorityText = "SENIOR PRIORITY"
        CASE "Pregnant":
            SET priorityText = "PRIORITY"
        CASE "Regular":
            SET priorityText = "REGULAR"
        DEFAULT:
            SET priorityText = "REGULAR"
    END SWITCH

    DISPLAY queueString, patientType, priorityText
    SET queueCounter = queueCounter + 1
END

WHEN CLEAR is clicked
BEGIN CLEAR
    SET PatientName.Text = ""
    SET Age.Text = ""
    SET ReasonForVisit.SelectedIndex = -1
    SET PatientType.SelectedIndex = -1
END
